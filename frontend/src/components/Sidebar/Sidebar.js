import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import "./Sidebar.css";
import logo from "../../assets/images/icons/Logo.png";
import dashboardIcon from "../../assets/images/icons/dashboard.png";
import patientsIcon from "../../assets/images/icons/patient.png";
import dossiersIcon from "../../assets/images/icons/dossiers.png";
import consultationsIcon from "../../assets/images/icons/consultations.png";
import appointmentsIcon from "../../assets/images/icons/appointment.png";
import billingIcon from "../../assets/images/icons/billing.png";
import logoutIcon from "../../assets/images/icons/logout.png";

const Sidebar = () => {
  const [activeDropdown, setActiveDropdown] = useState(null);

  const toggleDropdown = (dropdown) => {
    setActiveDropdown(activeDropdown === dropdown ? null : dropdown);
  };

  return (
    <div className="sidebar-card">
      <div className="logo">
        <img src={logo} alt="Logo" />
      </div>
      <ul className="nav-links">
        <li>
          <NavLink to="/dentiste-dashboard" className={({ isActive }) => (isActive ? "active" : "")}>
            <img src={dashboardIcon} alt="Dashboard" className="icon" /> Dashboard
          </NavLink>
        </li>
        <li className={`dropdown ${activeDropdown === "patients" ? "active" : ""}`}>
          <a href="#" onClick={() => toggleDropdown("patients")}>
            <img src={patientsIcon} alt="Patients" className="icon" /> Patients
          </a>
          <ul className="dropdown-menu">
            <li>
              <NavLink to="/patients/list">List Patients</NavLink>
            </li>
            <li>
              <NavLink to="/patients/add">Add Patient</NavLink>
            </li>
          </ul>
        </li>
        <li className={`dropdown ${activeDropdown === "dossiers" ? "active" : ""}`}>
          <a href="#" onClick={() => toggleDropdown("dossiers")}>
            <img src={dossiersIcon} alt="Dossiers" className="icon" /> Dossiers
          </a>
          <ul className="dropdown-menu">
            <li>
              <NavLink to="/dossiers/list">List Dossiers</NavLink>
            </li>
            <li>
              <NavLink to="/dossiers/add">Add Dossier</NavLink>
            </li>
          </ul>
        </li>
        <li className={`dropdown ${activeDropdown === "consultations" ? "active" : ""}`}>
          <a href="#" onClick={() => toggleDropdown("consultations")}>
            <img src={consultationsIcon} alt="Consultations" className="icon" /> Consultations
          </a>
          <ul className="dropdown-menu">
            <li>
              <NavLink to="/consultations/list">List Consultations</NavLink>
            </li>
            <li>
              <NavLink to="/consultations/add">Add Consultation</NavLink>
            </li>
          </ul>
        </li>
        <li className={`dropdown ${activeDropdown === "appointments" ? "active" : ""}`}>
          <a href="#" onClick={() => toggleDropdown("appointments")}>
            <img src={appointmentsIcon} alt="Appointments" className="icon" /> Appointments
          </a>
          <ul className="dropdown-menu">
            <li>
              <NavLink to="/appointments/list">List Appointments</NavLink>
            </li>
            <li>
              <NavLink to="/appointments/add">Add Appointment</NavLink>
            </li>
          </ul>
        </li>
        <li>
          <NavLink to="/billing">
            <img src={billingIcon} alt="Billing" className="icon" /> Billing
          </NavLink>
        </li>
        <li>
          <NavLink to="/logout">
            <img src={logoutIcon} alt="Logout" className="icon" /> Logout
          </NavLink>
        </li>
      </ul>
    </div>
  );
};

export default Sidebar;
