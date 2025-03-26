const axios = require('axios');

const url = 'https://api.sintegrapi.com.br/consultas/sintegra/15436940000103';
const apiKey = 'SUA_API_KEY';

axios.get(url, { headers: { 'x-api-key': apiKey } })
  .then(response => console.log(response.data))
  .catch(error => console.error(error));

  // node exemplo.js