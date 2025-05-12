import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom"; // Import useParams for getting route parameters
import axios from "axios";
import Sidebar from "../Sidebar/Sidebar"; // Import Sidebar
import "./AddPatient.css"; // Reuse AddPatient.css for consistent styling

const EditPatient = () => {
    const { id } = useParams(); // Extract the 'id' from the route parameters
    const [formData, setFormData] = useState({
        telephone: "",
        email: "",
        sexe: "Homme",
        adresse: "",
        dateNaissance: "",
        prenom: "",
        nom: "",
        cin: "",
        groupeSanguin: "A_Positif",
        mutuelle: "Yes",
        profession: "",
    });

    const [successMessage, setSuccessMessage] = useState("");
    const [errorMessage, setErrorMessage] = useState("");

    useEffect(() => {
        fetchPatientData();
    }, []);

    const fetchPatientData = async () => {
        try {
            const response = await axios.get(`http://localhost:5000/api/patient/${id}`);
            if (response.data.success) {
                setFormData(response.data.data);
            } else {
                setErrorMessage("Error: " + response.data.message);
            }
        } catch (error) {
            console.error("Error fetching patient data:", error);
            setErrorMessage(error.message);
        }
    };

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        setSuccessMessage("");
        setErrorMessage("");

        try {
            const response = await axios.put(`http://localhost:5000/api/patient/edit/${id}`, formData);

            if (response.data.success) {
                setSuccessMessage(response.data.message);
            } else {
                setErrorMessage("Error: " + response.data.message);
            }
        } catch (error) {
            console.error("Error updating patient:", error);
            const errorMessage =
                error.response?.data?.message || "An unexpected error occurred";
            setErrorMessage(errorMessage);
        }
    };

    return (
        <div className="main-content">
            <Sidebar />
            <div className="form-container">
                <h2>Edit Patient</h2>
                {successMessage && <div className="success-message">{successMessage}</div>}
                {errorMessage && <div className="error-message">{errorMessage}</div>}
                <form onSubmit={handleSubmit}>
                    <div className="form-row">
                        <div className="form-column">
                            <label>Telephone:</label>
                            <input
                                type="text"
                                name="telephone"
                                value={formData.telephone}
                                onChange={handleChange}
                                required
                            />

                            <label>Email:</label>
                            <input
                                type="email"
                                name="email"
                                value={formData.email}
                                onChange={handleChange}
                                required
                            />

                            <label>Gender:</label>
                            <select name="sexe" value={formData.sexe} onChange={handleChange}>
                                <option value="Homme">Male</option>
                                <option value="Femme">Female</option>
                                <option value="Autre">Other</option>
                            </select>
                        </div>

                        <div className="form-column">
                            <label>First Name:</label>
                            <input
                                type="text"
                                name="prenom"
                                value={formData.prenom}
                                onChange={handleChange}
                                required
                            />

                            <label>Last Name:</label>
                            <input
                                type="text"
                                name="nom"
                                value={formData.nom}
                                onChange={handleChange}
                                required
                            />

                            <label>CIN:</label>
                            <input
                                type="text"
                                name="cin"
                                value={formData.cin}
                                onChange={handleChange}
                                required
                            />
                        </div>

                        <div className="form-column">
                            <label>Address:</label>
                            <input
                                type="text"
                                name="adresse"
                                value={formData.adresse}
                                onChange={handleChange}
                            />

                            <label>Birth Date:</label>
                            <input
                                type="date"
                                name="dateNaissance"
                                value={formData.dateNaissance}
                                onChange={handleChange}
                            />

                            <label>Blood Group:</label>
                            <select
                                name="groupeSanguin"
                                value={formData.groupeSanguin}
                                onChange={handleChange}
                            >
                                <option value="A_Positif">A Positive</option>
                                <option value="A_Negatif">A Negative</option>
                                <option value="B_Positif">B Positive</option>
                                <option value="B_Negatif">B Negative</option>
                                <option value="AB_Positif">AB Positive</option>
                                <option value="AB_Negatif">AB Negative</option>
                                <option value="O_Positif">O Positive</option>
                                <option value="O_Negatif">O Negative</option>
                            </select>
                        </div>

                        <div className="form-column">
                            <label>Insurance:</label>
                            <select name="mutuelle" value={formData.mutuelle} onChange={handleChange}>
                                <option value="Yes">Yes</option>
                                <option value="No">No</option>
                            </select>

                            <label>Profession:</label>
                            <input
                                type="text"
                                name="profession"
                                value={formData.profession}
                                onChange={handleChange}
                            />
                        </div>
                    </div>
                    <button type="submit" className="action-link">Submit</button>
                </form>
            </div>
        </div>
    );
};

export default EditPatient;
