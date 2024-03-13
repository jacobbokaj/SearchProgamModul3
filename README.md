SOVS I KASKETTEN LIGE I RUMPÆTTEN

#### Get words

```http
  GET /database/words
```
#### Get word by id

```http
  GET database/words/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to get   |


#### Get word by name and caseSensitive

```http
  GET /database/names?query=names&cs=bool
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :----------------------------------------|
| `query`   | `string` | **Required**. if multiple names use `_` to split the names|
| `cs`      | `string` | **Required**. `cs` for `caseSensitive` can be `true` or `false` |

