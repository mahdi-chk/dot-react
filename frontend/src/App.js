import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Login from './components/Login/Login';
import SecretaireDashboard from './components/Dashboard/SecretaireDashboard';
import DentisteDashboard from './components/Dashboard/DentisteDashboard';
import AddPatient from './components/Patient/AddPatient';
import PatientList from './components/Patient/PatientList';
import AddEmployee from './components/Employee/AddEmployee';
import EditPatient from './components/Patient/EditPatient'; // Import EditPatient component

const App = () => {
    return (
        <Router>
            <Routes>
                {/* Login Route */}
                <Route path="/" element={<Login />} />

                {/* Dashboards */}
                <Route path="/secretaire-dashboard" element={<SecretaireDashboard />} />
                <Route path="/dentiste-dashboard" element={<DentisteDashboard />} />

                {/* Patient Routes */}
                <Route path="/patients/add" element={<AddPatient />} />
                <Route path="/patients/list" element={<PatientList />} />
                <Route path="/patients/edit/:id" element={<EditPatient />} /> {/* EditPatient route */}

                {/* Employee Routes */}
                <Route path="/employees/add" element={<AddEmployee />} />

                {/* Catch-All Route (404 Page) */}
                <Route
                    path="*"
                    element={
                        <div style={{ textAlign: 'center', marginTop: '50px' }}>
                            <h2>404 - Page Not Found</h2>
                            <a
                                href="/"
                                style={{
                                    color: '#007bff',
                                    textDecoration: 'none',
                                }}
                            >
                                Go to Login
                            </a>
                        </div>
                    }
                />
            </Routes>
        </Router>
    );
};

export default App;
