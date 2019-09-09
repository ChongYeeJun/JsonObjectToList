# JsonObjectToList
Convert JSON object into list with key and value pair using model binding in .net framework web api

Input
{
    "name": "My Name",
    "age": "30"
}

Return
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
