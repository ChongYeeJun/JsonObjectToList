# JsonObjectToList
Convert JSON object into list with key and value pair using model binding in .net framework web api

URL: http://localhost:xxxx/api/values <br/>
Method: POST <br />
Request Body:
```
{
    "name": "My Name",
    "age": "30"
}
```

Response Body:
```
{
    "KeyValuePairs": [
        {
            "Key": "name",
            "Value": "My Name"
        },
        {
            "Key": "age",
            "Value": "30"
        }
    ]
}
```
