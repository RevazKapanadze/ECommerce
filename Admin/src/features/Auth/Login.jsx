import React, { useState } from "react";
import { user } from "../../app/api/agent";

export const Login = (props) => {
  const [username, setUsername] = useState('');
  const [password, setPass] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    user.login(username, password)
      .then(data => {
        console.log("Login successful!", data);
        localStorage.setItem('Token', data);
        props.onFormSwitch('chooseCompany');
      })
      .catch(error => {
        console.error("Login failed:", error);
      });
  }

  return (
    <div className="auth-form-container">
      <h2>Login</h2>
      <form className="login-form" onSubmit={handleSubmit}>
        <label htmlFor="username">Username</label>
        <input
          value={username}
          onChange={(e) => setUsername(e.target.value)}
          type="text" // You can use 'text' instead of 'email' for a username
          placeholder="YourUsername123"
          id="username"
          name="username"
        />
        <label htmlFor="password">Password</label>
        <input
          value={password}
          onChange={(e) => setPass(e.target.value)}
          type="password"
          placeholder="********"
          id="password"
          name="password"
        />
        <button type="submit">Log In</button>
      </form>
      <button className="link-btn" onClick={() => props.onFormSwitch('register')}>
        Don't have an account? Register here.
      </button>
    </div>
  );
};
