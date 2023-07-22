import React, { useState } from "react";
import { company } from "../../app/api/agent";

export const CompanyRegister = (props) => {
  const [name, setName] = useState('');
  const [nameForUrl, setnameForUrl] = useState('');
  const [locationUrl, setlocationUrl] = useState('');
  const [paymentDay, setpaymentDay] = useState('');
  const [themeColour, setthemeColour] = useState('');
  const [location, setlocation] = useState('');
  const [description, setdescription] = useState('');


  const handleSubmit = (e) => {
    e.preventDefault();
    company.createcompany(name, nameForUrl, locationUrl, paymentDay, themeColour, location, description)
      .then(data => {
        console.log("Login successful!", data);

        props.onFormSwitch('chooseCompany');
      })
      .catch(error => {
        console.error("Login failed:", error);
      });
  }

  return (
    <div className="auth-form-container">
      <h2>Create Company</h2>
      <form className="register-form" onSubmit={handleSubmit}>
        <label htmlFor="name">Company Name</label>
        <input value={name} name="name" onChange={(e) => setName(e.target.value)} id="name" placeholder="Bank of Georgia" />

        <label htmlFor="Short Name for URL">name For Url</label>
        <input value={nameForUrl} name="nameForUrl" onChange={(e) => setnameForUrl(e.target.value)} id="nameForUrl" placeholder="BOG" />

        <label htmlFor="locationUrl">Location Url</label>
        <input value={locationUrl} onChange={(e) => setlocationUrl(e.target.value)} placeholder="https://goo.gl/maps/NQBcBJGSjWeCY4nB7" id="locationUrl" name="locationUrl" />

        <label htmlFor="location">Location</label>
        <input value={location} onChange={(e) => setlocation(e.target.value)} placeholder="29a იური გაგარინის ქუჩა, თბილისი" id="location" name="location" />

        <label htmlFor="paymentDay">Payment Day</label>
        <input value={paymentDay} onChange={(e) => setpaymentDay(e.target.value)} placeholder="15" id="paymentDay" name="paymentDay" />

        <label htmlFor="themeColour">Theme Colour</label>
        <input value={themeColour} onChange={(e) => setthemeColour(e.target.value)} placeholder="Red" id="themeColour" name="themeColour" />

        <label htmlFor="description">Description</label>
        <input value={description} onChange={(e) => setdescription(e.target.value)} placeholder="15" id="description" name="description" />

        <button type="submit">Create Company</button>
      </form>
      <button className="link-btn" onClick={() => props.onFormSwitch('chooseCompany')}>Get Back to Choosing company</button>
    </div>
  );
};
