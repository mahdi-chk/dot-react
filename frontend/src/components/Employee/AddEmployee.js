import React, { useState } from "react";
import axios from "axios";
import "./AddEmployee.css"; // Add your custom styles here

const AddEmployee = () => {
  const [formData, setFormData] = useState({
    role: "Dentist", // Default role
    telephone: "",
    email: "",
    sexe: "",
    adresse: "",
    dateNaissance: "",
    prenom: "",
    nom: "",
    cin: "",
    photoDeProfile: "",
    dateDerniereConnexion: "",
    motDePasse: "",
    dateDeModification: "",
    nomUtilisateur: "",
    dateDeCreation: "",
    statusActuel: "",
    salaireDeBase: "",
    dateRetourConge: "",
    specialite: "",
    prime: "",
  });

  const [successMessage, setSuccessMessage] = useState("");
  const [errorMessage, setErrorMessage] = useState("");

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const url =
        formData.role === "Dentist"
          ? "https://localhost:5001/api/Dentistes"
          : "https://localhost:5001/api/Secretaires";
      const response = await axios.post(url, formData);
      setSuccessMessage("Employee added successfully!");
      setErrorMessage("");
    } catch (error) {
      setErrorMessage(error.response?.data?.message || "An error occurred.");
      setSuccessMessage("");
    }
  };

  return (
    <div className="form-container">
      <h2>Add Employee</h2>
      {successMessage && <div className="success-message">{successMessage}</div>}
      {errorMessage && <div className="error-message">{errorMessage}</div>}

      <form onSubmit={handleSubmit}>
        <div className="form-row">
          <div className="form-column">
            <label>Role:</label>
            <select name="role" value={formData.role} onChange={handleChange} required>
              <option value="Dentist">Dentist</option>
              <option value="Secretary">Secretary</option>
            </select>

            <label>Telephone:</label>
            <input type="text" name="telephone" value={formData.telephone} onChange={handleChange} required />

            <label>Email:</label>
            <input type="email" name="email" value={formData.email} onChange={handleChange} required />

            <label>Sexe:</label>
            <select name="sexe" value={formData.sexe} onChange={handleChange} required>
              <option value="">Select</option>
              <option value="Homme">Male</option>
              <option value="Femme">Female</option>
              <option value="Autre">Other</option>
            </select>

            <label>Adresse:</label>
            <input type="text" name="adresse" value={formData.adresse} onChange={handleChange} />

            <label>Date Naissance:</label>
            <input type="date" name="dateNaissance" value={formData.dateNaissance} onChange={handleChange} />
          </div>

          <div className="form-column">
            <label>Prenom:</label>
            <input type="text" name="prenom" value={formData.prenom} onChange={handleChange} required />

            <label>Nom:</label>
            <input type="text" name="nom" value={formData.nom} onChange={handleChange} required />

            <label>CIN:</label>
            <input type="text" name="cin" value={formData.cin} onChange={handleChange} />

            <label>Photo de Profile:</label>
            <input type="text" name="photoDeProfile" value={formData.photoDeProfile} onChange={handleChange} />

            <label>Date Dernière Connexion:</label>
            <input type="date" name="dateDerniereConnexion" value={formData.dateDerniereConnexion} onChange={handleChange} />

            <label>Mot de Passe:</label>
            <input type="password" name="motDePasse" value={formData.motDePasse} onChange={handleChange} required />
          </div>
        </div>

        <div className="form-row">
          <div className="form-column">
            <label>Date de Modification:</label>
            <input type="date" name="dateDeModification" value={formData.dateDeModification} onChange={handleChange} />

            <label>Nom Utilisateur:</label>
            <input type="text" name="nomUtilisateur" value={formData.nomUtilisateur} onChange={handleChange} />

            <label>Date de Creation:</label>
            <input type="date" name="dateDeCreation" value={formData.dateDeCreation} onChange={handleChange} />

            <label>Status Actuel:</label>
            <select name="statusActuel" value={formData.statusActuel} onChange={handleChange}>
              <option value="">Select</option>
              <option value="Active">Active</option>
              <option value="Inactive">Inactive</option>
            </select>

            <label>Salaire de Base:</label>
            <input type="number" name="salaireDeBase" value={formData.salaireDeBase} onChange={handleChange} />
          </div>

          <div className="form-column">
            <label>Date Retour Conge:</label>
            <input type="date" name="dateRetourConge" value={formData.dateRetourConge} onChange={handleChange} />

            {/* Show Specialite for Dentists */}
            {formData.role === "Dentist" && (
              <>
                <label>Specialite:</label>
                <input type="text" name="specialite" value={formData.specialite} onChange={handleChange} />
              </>
            )}

            {/* Show Prime for Secretaries */}
            {formData.role === "Secretary" && (
              <>
                <label>Prime:</label>
                <input type="number" name="prime" value={formData.prime} onChange={handleChange} />
              </>
            )}
          </div>
        </div>

        <button type="submit">Add Employee</button>
      </form>
    </div>
  );
};

export default AddEmployee;
