use reqwest::blocking::Client;
use std::error::Error;

fn main() -> Result<(), Box<dyn Error>> {
    let client = Client::new();
    let url = "https://api.sintegrapi.com.br/consultas/sintegra/15436940000103";
    
    let response = client.get(url)
        .header("x-api-key", "SUA_API_KEY")
        .send()?;
    
    println!("RESPONSE:");
    println!("{}", response.status());
    println!("{}", response.text()?);

    Ok(())
}
