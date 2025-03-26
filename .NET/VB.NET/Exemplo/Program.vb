Imports System
Imports System.Net.Http

Module Program
    Sub Main()
        Execute().GetAwaiter().GetResult()
    End Sub

    Public Async Function Execute() As Task

        Dim apiUrl As String = "https://api.sintegrapi.com.br/consultas/sintegra/15436940000103"
        Dim apiKey As String = "SUA_API_KEY" 'ADICIONE AQUI SUA CHAVE DE API
        Using client As New HttpClient()

            client.DefaultRequestHeaders.Add("x-api-key", apiKey)

            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim responseData As String = Await response.Content.ReadAsStringAsync()
                    Console.WriteLine("Resposta da API:")
                    Console.WriteLine(responseData)
                Else
                    Console.WriteLine("Erro ao consultar API. Status Code: " & response.StatusCode)
                End If
            Catch ex As Exception
                Console.WriteLine("Erro ao fazer a requisição: " & ex.Message)
            End Try
        End Using
    End Function


End Module
