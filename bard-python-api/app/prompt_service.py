import asyncio
from Bard import AsyncChatbot

async def get_prompt_response(prompt: str):

    Secure_1PSID = "Secure_1PSID Cookie"
    Secure_1PSIDTS = "Secure_1PSIDTS Cookie"

    chatbot = await AsyncChatbot.create(Secure_1PSID, Secure_1PSIDTS)
    response = await chatbot.ask(prompt)

    return response['content']