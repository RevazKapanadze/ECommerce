import React, { useState } from "react";
import { user } from "../../app/api/agent";
export const Register = (props) => {
  const [email, setEmail] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [pass, setPass] = useState('');
  const [userName, setName] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    user.register(userName, pass, email, phoneNumber)
      .then(response => {
        // Handle the registration response data here
        console.log("Register successful!", response.data);
        props.onFormSwitch('login');

      })
      .catch(error => {
        // Handle any registration errors here (e.g., display an error message)
        console.error("Register failed:", error);
      });
  }

  return (
    <div className="auth-form-container">
      <h2>Register</h2>
      <form className="register-form" onSubmit={handleSubmit}>
        <label htmlFor="name">Username</label>
        <input value={userName} name="name" onChange={(e) => setName(e.target.value)} id="name" placeholder="UserName" />

        <label htmlFor="name">Phone Number</label>
        <input value={phoneNumber} name="phoneNumber" onChange={(e) => setPhoneNumber(e.target.value)} id="phoneNumber" placeholder="577123456" />

        <label htmlFor="email">email</label>
        <input value={email} onChange={(e) => setEmail(e.target.value)} type="email" placeholder="youremail@gmail.com" id="email" name="email" />
        <label htmlFor="password">password</label>
        <input value={pass} onChange={(e) => setPass(e.target.value)} type="password" placeholder="********" id="password" name="password" />
        <button type="submit">Register</button>
      </form>
      <button className="link-btn" onClick={() => props.onFormSwitch('login')}>Already have an account? Login here.</button>
    </div>
  )
}