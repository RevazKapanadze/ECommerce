import axios from 'axios';
import { toast } from "react-toastify";

//axios.defaults.withCredentials = true;
//axios.defaults.baseURL = process.env.REACT_APP_API_URL;
axios.defaults.baseURL = 'http://localhost:5098/api/';
axios.interceptors.request.use(config => {
  const token = localStorage.getItem('Token');
  config.headers = config.headers ?? {};
  if (token) config.headers.Authorization = `Bearer ${token}`;
  return config;
});

export const responseBody = (response) => response.data;

axios.interceptors.response.use(response => {
  return response;
}, (error) => {
  const { data, status } = error.response;
  switch (status) {
    case 400:
      if (data.errors) {
        const modelStateErrors = [];
        for (const key in data.errors) {
          if (data.errors[key]) {
            modelStateErrors.push(data.errors[key]);
            // Display each error message from the modelStateErrors array as a toast error
            data.errors[key].forEach(errorMessage => {
              toast.error(errorMessage);
            });
          }
        }
        throw modelStateErrors.flat();
      }
      toast.error(data.title);
      break;
    case 401:
      toast.error(data.title || 'Unauthorized');
      break;
    case 500:
      toast.error(data.title)
      break;
    default:
      break;
  }
  return Promise.reject(error.response);
});


export const requests = {
  get: (url, params) => axios.get(url, { params }).then(responseBody),
  post: (url, body) => axios.post(url, body).then(responseBody),
  put: (url, body) => axios.put(url, body).then(responseBody),
  delete: (url) => axios.delete(url).then(responseBody),
};

const user = {
  login: (userName, password) => requests.post('user/login', { userName, password }),
  register: (userName, password, email, phoneNumber) => requests.post('user/register', { userName, password, email, phoneNumber })
};
const company = {
  getallcompanies: () => requests.get('company/get-all-companies'),
  createcompany: (name, nameForUrl, locationUrl, paymentDay, themeColour, location, description) => requests.post('company/create-company', { name, nameForUrl, locationUrl, paymentDay, themeColour, location, description })
};

export { user, company }; // Export the user object
