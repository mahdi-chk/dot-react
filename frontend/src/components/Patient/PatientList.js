import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import Sidebar from "../Sidebar/Sidebar";
import "./PatientList.css"; // Using shared dashboard styles

const PatientList = () => {
  const [patients, setPatients] = useState([]);
  const [message, setMessage] = useState({ type: "", text: "" });
  const navigate = useNavigate();

  // Fetch patients on component mount
  useEffect(() => {
    fetchPatients();
  }, []);

  const fetchPatients = async () => {
    try {
      const response = await axios.get("http://localhost:5000/api/patient");
      setPatients(response.data.data);
    } catch (error) {
      handleError(error);
    }
  };

  const deletePatient = async (id) => {
    try {
      const response = await axios.delete(`http://localhost:5000/api/patient/delete/${id}`);
      if (response.data.success) {
        setMessage({ type: "success", text: "Patient deleted successfully." });
        setPatients(patients.filter((patient) => patient.id !== id));
      }
    } catch (error) {
      handleError(error);
    }
  };

  const handleError = (error) => {
    if (error.response && error.response.data) {
      setMessage({ type: "error", text: error.response.data.message || "An error occurred." });
    } else if (error.request) {
      setMessage({ type: "error", text: "Error connecting to the server." });
    } else {
      setMessage({ type: "error", text: error.message });
    }
  };

  return (
    <>
      <Sidebar />
      <div className="main-content">
       
        {message.text && (
          <div
            className={message.type === "success" ? "success-message" : "error-message"}
          >
            {message.text}
          </div>
        )}
        <table className="appointments-table">
          <thead>
            <tr>
              <th>First Name</th>
              <th>Last Name</th>
              <th>CIN</th>
              <th>Actions</th>
            </tr>
          </thead>
          <tbody>
            {patients.length > 0 ? (
              patients.map((patient) => (
                <tr key={patient.id}>
                  <td>{patient.prenom}</td>
                  <td>{patient.nom}</td>
                  <td>{patient.cin}</td>
                  <td>
                    <button
                      className="action-link"
                      onClick={() => navigate(`/patients/edit/${patient.id}`)}
                    >
                      Edit
                    </button>
                    <button
                      className="action-link"
                      onClick={(e) => {
                        e.preventDefault();
                        if (window.confirm("Are you sure you want to delete?")) {
                          deletePatient(patient.id);
                        }
                      }}
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              ))
            ) : (
              <tr>
                <td colSpan="4">No patients found.</td>
              </tr>
            )}
          </tbody>
        </table>
      </div>
    </>
  );
};

export default PatientList;
