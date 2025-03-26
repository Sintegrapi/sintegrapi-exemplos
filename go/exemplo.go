package main

import (
	"fmt"
	"io"
	"net/http"
)

func main() {
	url := "https://api.sintegrapi.com.br/consultas/sintegra/15436940000103"
	req, _ := http.NewRequest("GET", url, nil)
	req.Header.Set("x-api-key", "SUA_API_KEY")

	client := &http.Client{}
	resp, err := client.Do(req)
	if err != nil {
		fmt.Println("Erro:", err)
		return
	}
	defer resp.Body.Close()

	body, _ := io.ReadAll(resp.Body)
	fmt.Println(string(body))
}
// go run .\exemplo.go