import requests

def consultar_api():
    # URL da API
    url = "https://api.sintegrapi.com.br/consultas/sintegra/15436940000103"
    
    # Cabeçalhos com a chave da API
    headers = {
        'x-api-key': 'SUA_API_KEY'  # Substitua pela sua chave da API
    }
    
    try:
        # Enviando a requisição GET
        response = requests.get(url, headers=headers)
        
        # Verificando se a requisição foi bem-sucedida
        if response.status_code == 200:
            # Exibindo a resposta da API
            print("Resposta da API:")
            print(response.json())  # A resposta é convertida para JSON
        else:
            print(f"Erro ao consultar API. Status Code: {response.status_code}")
    
    except Exception as e:
        print(f"Erro ao fazer a requisição: {e}")

# Chama a função
consultar_api()
