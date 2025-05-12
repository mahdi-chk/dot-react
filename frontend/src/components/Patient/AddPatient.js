import React, { useState } from "react";
import axios from "axios";
import "./AddPatient.css";
import Sidebar from "../Sidebar/Sidebar";

const AddPatient = () => {
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

    const handleChange = (e) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        setSuccessMessage("");
        setErrorMessage("");

        try {
            const response = await axios.post("http://localhost:5000/api/patient/add", formData);

            if (response.data.success) {
                setSuccessMessage(
                    `Patient added successfully with ID: ${response.data.patientId} and dossier ID: ${response.data.dossierId}`
                );
                setFormData({
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
            } else {
                setErrorMessage("Error: " + response.data.message);
            }
        } catch (error) {
            console.error("Error during submission:", error);
            const errorMessage =
                error.response?.data?.message || "An unexpected error occurred";
            setErrorMessage(errorMessage);
        }
    };

    return (
        <div className="main-content">
            <Sidebar />
            <div className="form-container">
                <h2>Add Patient</h2>
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

export default AddPatient;
