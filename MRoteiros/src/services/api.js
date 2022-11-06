import axios from 'axios';

const api = axios.create({
    baseURL: 'https://localhost:7254/' || 'https://localhost:5254/'
});

export default api;