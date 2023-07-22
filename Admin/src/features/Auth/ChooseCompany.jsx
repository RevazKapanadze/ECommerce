import React, { useState, useEffect } from "react";
import { company } from "../../app/api/agent";

export const ChooseCompany = (props) => {
  const [companies, setCompanies] = useState([]);

  useEffect(() => {
    // Make the API call to retrieve the list of companies
    company.getallcompanies()
      .then((data) => {
        // Update the state with the retrieved companies
        setCompanies(data);
      })
      .catch((error) => {
        console.error("Failed to retrieve companies:", error);
      });
  }, []); // The empty dependency array ensures this effect runs only once when the component mounts

  // Handle clicking on a company name
  const handleCompanyClick = (companyId, themeColour, nameForUrl) => {
    // Store the selected company ID in local storage as "CompanyId"
    localStorage.setItem("CompanyId", companyId);
    localStorage.setItem("ThemeColour", themeColour);
    localStorage.setItem("NameForUrl", nameForUrl)
    console.log("Selected company ID:", companyId);
    console.log("Selected company themeColour:", themeColour);
    props.onFormSwitch('main');
  };

  return (
    <div className="auth-form-container" >
      <h2>ChooseCompany</h2>
      <form className="company-list">
        {/* Render the list of companies as clickable buttons */}
        {companies.map((company) => (
          <button key={company.id} onClick={() => handleCompanyClick(company.id, company.themeColour, company.nameForUrl)}>
            {company.name}
          </button>
        ))}
      </form>
      <button className="link-btn" onClick={() => props.onFormSwitch('companyRegister')}>
        Don't have an company? Create one here.
      </button>
    </div>
  );
};
