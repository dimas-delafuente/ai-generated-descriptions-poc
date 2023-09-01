from fastapi import HTTPException, status

from hugchat import hugchat
from hugchat.login import Login

def get_prompt_response(prompt: str):

    # Log in to huggingface and grant authorization to huggingchat
    sign = Login("email", "pwd")
    cookies = sign.login()

    # Save cookies to the local directory
    cookie_path_dir = "./cookies_snapshot"
    sign.saveCookiesToDir(cookie_path_dir)

    # Load cookies when you restart your program:
    # sign = login(email, None)
    # cookies = sign.loadCookiesFromDir(cookie_path_dir) # This will detect if the JSON file exists, return cookies if it does and raise an Exception if it's not.

    # Create a ChatBot
    chatbot = hugchat.ChatBot(cookies=cookies.get_dict())  # or cookie_path="usercookies/<email>.json"
    return chatbot.chat(prompt);