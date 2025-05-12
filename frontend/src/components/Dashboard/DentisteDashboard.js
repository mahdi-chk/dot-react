import React from "react";
import Sidebar from "../Sidebar/Sidebar";
import "./DentisteDashboard.css";

const DentisteDashboard = () => {
  const appointments = [
    { motif: "Checkup", date: "2025-01-12", patientName: "John Doe", type: "General" },
    { motif: "Filling", date: "2025-01-13", patientName: "Jane Smith", type: "Dental" },
  ];

  return (
    <>
      <Sidebar />
      <div className="dashboard-content">
        <div className="stats-overview">
          <div className="stat-card">
            <h3>120</h3>
            <p>Patients</p>
          </div>
          <div className="stat-card">
            <h3>45</h3>
            <p>Appointments</p>
          </div>
          <div className="stat-card">
            <h3>25,000 MAD</h3>
            <p>Total Earnings</p>
          </div>
          <div className="stat-card">
            <h3>2,500 MAD</h3>
            <p>Today's Amount</p>
          </div>
        </div>

        <div className="appointments-section">
          <h2>Recent Appointments</h2>
          <table className="appointments-table">
            <thead>
              <tr>
                <th>Motif</th>
                <th>Date</th>
                <th>Patient</th>
                <th>Type</th>
              </tr>
            </thead>
            <tbody>
              {appointments.map((appointment, index) => (
                <tr key={index}>
                  <td>{appointment.motif}</td>
                  <td>{appointment.date}</td>
                  <td>{appointment.patientName}</td>
                  <td>{appointment.type}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>
    </>
  );
};

export default DentisteDashboard;
