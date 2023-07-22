import { ToastContainer } from 'react-toastify';
import './App.css';
import { Login } from './features/Auth/Login';
import { Register } from './features/Auth/Register';
import { ChooseCompany } from './features/Auth/ChooseCompany';
import { CompanyRegister } from './features/Auth/CompanyRegister';
import React, { useState } from "react";
import 'react-toastify/dist/ReactToastify.css';
import { Main } from './features/MainGrid/Main';
function App() {
  const [currentForm, setCurrentForm] = useState('login');

  const toggleForm = (formName) => {
    setCurrentForm(formName);
  }
  let formComponent;
  if (currentForm === "login") {
    formComponent = <Login onFormSwitch={toggleForm} />;
  } else if (currentForm === "register") {
    formComponent = <Register onFormSwitch={toggleForm} />;
  } else if (currentForm === "chooseCompany") {
    formComponent = <ChooseCompany onFormSwitch={toggleForm} />;
  }
  else if (currentForm === "companyRegister") {
    formComponent = <CompanyRegister onFormSwitch={toggleForm} />;
  }
  else if (currentForm === "main") {
    formComponent = <Main onFormSwitch={toggleForm} />;
  }
  return (
    <><ToastContainer position="bottom-right" hideProgressBar theme="colored" />
      <div className="App">
        {
          formComponent
        }
      </div >
    </>
  );
}

export default App;
