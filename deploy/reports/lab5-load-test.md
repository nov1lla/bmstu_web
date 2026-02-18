# WebLab#5 load testing report (ApacheBench)

## Конфигурация балансировки

- Конфиг: `deploy/nginx/lab5.conf`
- GET/HEAD/OPTIONS -> upstream `api_read` с весами `2:1:1` (`api-main`, `api-read1`, `api-read2`)
- POST/PUT/PATCH/DELETE -> upstream `api_write` (`api-main`)
- Read-only инстансы: `APP_READ_ONLY=true`
- Mirror контур: `/mirror/*` -> `mirror_api_read` / `mirror_api_write`

## Команды запуска

```bash
docker compose -f deploy/docker-compose.lab5.yml up --build
```

## Команды нагрузочного теста

```bash
ab -n 2000 -c 50 http://127.0.0.1:8088/api/v1/products
ab -n 500 -c 25 -p post-product.json -T application/json http://127.0.0.1:8088/api/v1/products
ab -n 2000 -c 50 http://127.0.0.1:8088/mirror/api/v1/products
```

Пример `post-product.json`:

```json
{
  "name": "Mouse G102",
  "price": 1990,
  "quantity": 10,
  "manufacturer": "Logitech",
  "description": "Gaming mouse"
}
```

## Что проверять на защите

- GET-запросы распределяются по 3 backend согласно весам (по access-log каждого API)
- Запросы на запись идут только на `api-main`
- При прямом запросе на readonly backend запись получает `405` с `{"error":"This backend is read-only."}`
- `/mirror` и `/mirror/api/v1` работают независимо от `/`
