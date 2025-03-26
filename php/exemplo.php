<?php
 
$url = "https://api.sintegrapi.com.br/consultas/sintegra/15436940000103";
$apiKey = "SUA_API_KEY";  // Substitua pela sua chave da API
 
$ch = curl_init();
 
curl_setopt($ch, CURLOPT_URL, $url);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, [
    "x-api-key: $apiKey"
]);
 

// Atenção, nos adicionamos essa linha abaixo para que seja possível utilizar o exemplo, ela desabilita a verificação SSL (não é recomendado para produção)
// se estiver no linux, você pode adicionar os certificados em seu servidor e remover essa linha. No windows, você pode instalar o certificado da autoridade certificadora no servidor.
curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
/* 
***PARA INSTALAR OS CERTIFICADOS NO LINUX***
sudo apt-get update
sudo apt-get install ca-certificates
sudo update-ca-certificates
*/


$response = curl_exec($ch);
 
if(curl_errno($ch)) {
    echo 'Erro no cURL: ' . curl_error($ch);
} else { 
    $statusCode = curl_getinfo($ch, CURLINFO_HTTP_CODE);
    echo "Status Code: $statusCode\n";
    echo "Response Body: $response\n";
}
 
curl_close($ch);

?>