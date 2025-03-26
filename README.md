# 📌 Exemplos de Integração - Sintegra API

Bem-vindo ao repositório de exemplos da **Sintegra API**! Aqui você encontrará implementações em diversas linguagens de programação para facilitar a integração com nossa API e realizar consultas fiscais de forma rápida e eficiente.

## 🚀 Sobre a Sintegra API  

A **Sintegra API** é uma solução moderna para consultas de **cnpj na receita federal, inscrição estadual, dados fiscais e tributários**. Nossa API permite automatizar verificações fiscais de maneira prática, reduzindo erros manuais e otimizando processos contábeis.  

Acesse nosso site para mais informações: [Sintegra API](https://sintegrapi.com.br)

Também temos a documentação oficial da nossa API em: [Sintegra API Documentação](https://docs.sintegrapi.com.br)

---

## 📂 Exemplos Disponíveis  

### 🔹 Requisição GET para consulta de um CNPJ no Sintegra  

| Linguagem | Código-fonte                                  |
|-----------|-----------------------------------------------|
| Node.js   | [exemplo-node.js](./nodejs/exemplo.js)          |
| PHP       | [exemplo-php.php](./php/exemplo.php)          |
| C#        | [exemplo-csharp.cs](./.NET/csharp/Program.cs) |
| VB.NET    | [exemplo-vbnet.cs](./.NET/VB.NET/Exemplo/Program.vb)  |
| Python    | [exemplo-python.py](./python/exemplo.py)      |
| Go        | [exemplo-go.go](./go/exemplo.go)              |
| Java      | [exemplo-java.java](./java/exemplo.java)      |
| Rust      | [exemplo-rust.rs](./rust/src/main.rs)         |

Cada um dos arquivos acima contém uma implementação funcional para acessar a API e obter os dados de um CNPJ.

---

## 🔧 Como Usar os Exemplos  

1. **Clone o repositório**  
   ```bash
   git clone https://github.com/sintegrapi/sintegrapi-examples.git   
   cd sintegrapi-examples
   ```
2. Substitua `"SUA_API_KEY"` pela sua chave de acesso válida
3. Execute o código na linguagem desejada. Exemplo para Python:

```bash
python python/exemplo.py
```

## 📜 Exemplo de Requisição
Aqui está um exemplo de requisição via cURL:

```bash
curl --request GET \
  --url https://api.sintegrapi.com.br/consultas/sintegra/15436940000103 \
  --header 'x-api-key: SUA_API_KEY'
```

## 📢 Contribuições
Fique à vontade para abrir issues e enviar pull requests com melhorias ou novos exemplos!

📧 Contato: suporte@sintegrapi.com.br
🌍 Site Oficial: https://sintegrapi.com.br


