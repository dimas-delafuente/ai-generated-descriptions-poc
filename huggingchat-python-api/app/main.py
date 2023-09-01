from typing import Union
from fastapi import FastAPI

from app.prompt_schema import PromptRequest
from app.prompt_service import get_prompt_response

app = FastAPI()


@app.get("/")
def read_root():
    return {"Hello": "World"}

@app.post("/prompts/")
async def create_item(request: PromptRequest):
    return get_prompt_response(request.prompt)