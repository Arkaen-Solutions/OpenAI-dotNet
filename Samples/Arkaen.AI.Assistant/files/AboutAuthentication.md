___
# How to authenticate with OpenAI:

---

## 1) Authenticate via environment variables:

	- Set environment variables "OPENAI_ORGANIZATION_" and "OPENAI_API_KEY" ...
	- The values shall be set to the appropriate organization name and API key

## 2) Via configuration file:

	- Create a file named ".openai" (json format)
	- Add properties "apiKey" and "orgName"

### Example

```json
{
	"apiKey": "sk-xxxxxxxxxxxxxxxxxxx",
	"organization": "org-NameHere"
}
```



___

### TODO: 
	- More secure key/name storage & retrieval mechanism