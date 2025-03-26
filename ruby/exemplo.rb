require 'net/http'
require 'json'
require 'uri'

uri = URI.parse("https://api.sintegrapi.com.br/consultas/sintegra/15436940000103")
request = Net::HTTP::Get.new(uri)
request["x-api-key"] = "SUA_API_KEY"

response = Net::HTTP.start(uri.host, uri.port, use_ssl: true) do |http|
  http.request(request)
end

puts response.code
puts response.body
