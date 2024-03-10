SOVS I KASKETTEN LIGE I RUMPÆTTEN

#### Get words

```http
  GET /Database/words
```
#### Get word by id

```http
  GET Database/words/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to get   |


#### Get word by name and caseSensitive

```http
  GET /Database/names?query=names&cs=bool
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :----------------------------------------|
| `query`   | `string` | **Required**. if multiple names use `_` to split the names|
| `cs`      | `string` | **Required**. `cs` for `caseSensitive` can be `true` or `false` |

