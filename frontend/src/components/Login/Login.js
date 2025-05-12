import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom'; // Ensure react-router-dom is installed
import './Login.css';
import logo from '../../assets/images/Logo.png';

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [errorMessage, setErrorMessage] = useState('');
    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();

        if (username === '' || password === '') {
            setErrorMessage('Please fill in both fields.');
            return;
        }

        try {
            // Make an API call to your backend for authentication
            const response = await fetch('https://localhost:5001/api/auth/login', {
                method: 'POST',
                headers: {
                  'Content-Type': 'application/json',
                },
                body: JSON.stringify({ username, password }),
              });
              

            const data = await response.json();

            if (data.success) {
                // Save the token (if any) in localStorage
                localStorage.setItem('token', data.token);

                // Redirect based on the user's role
                if (data.role === 'Secretaire') {
                    navigate('/secretaire-dashboard');
                } else if (data.role === 'Dentiste') {
                    navigate('/dentiste-dashboard');
                } else {
                    setErrorMessage('Unknown user role.');
                }
            } else {
                setErrorMessage(data.message || 'Invalid login credentials.');
            }
        } catch (error) {
            console.error('Login error:', error);
            setErrorMessage('Something went wrong. Please try again.');
        }
    };

    return (
        <div className="login-container">
            <div className="logo">
                <img src={logo} alt="Logo" />
            </div>
            <h2>Login</h2>
            {errorMessage && <div className="error-message">{errorMessage}</div>}
            <form onSubmit={handleSubmit}>
                <div className="form-group">
                    <label htmlFor="username">Username or Email:</label>
                    <input
                        type="text"
                        id="username"
                        value={username}
                        onChange={(e) => setUsername(e.target.value)}
                        required
                    />
                </div>
                <div className="form-group">
                    <label htmlFor="password">Password:</label>
                    <input
                        type="password"
                        id="password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        required
                    />
                </div>
                <div className="form-group">
                    <button type="submit">Login</button>
                </div>
            </form>
        </div>
    );
};

export default Login;
