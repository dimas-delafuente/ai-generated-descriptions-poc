# ai-generated-descriptions-poc

AI generated products descriptions POC using HuggingChat and Bard python clients.

  

## Python clients

Bard Python client:

https://github.com/acheong08/Bard

  

HuggingChat Python client:

https://github.com/Soulter/hugging-chat-api

  

## How to run

1. Build docker images:

>     docker build -t huggingchat .
>     docker build -t bardchat .

2. Run docker images

>     docker run -d --name huggingchat-api -p 8084:8084 huggingchat
>     docker run -d --name bardchat-api -p 8084:8084 bardchat

3. Run Blazor app