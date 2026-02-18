# WebLab#4 checklist

## Что настроено

- `nginx` конфиг: `deploy/nginx/lab4.conf`
- Маршрутизация API: `/api/v1`, `/api/v2` -> `api-main`
- Swagger UI: доступен через API по `/api/v1` и `/api/v2`
- Legacy страница: `/legacy`
- Документация: `/documentation` (отдача `README.md`)
- Статика: `/` и `/reserved` -> `deploy/static/index.html`
- Web admin DB: `/admin` -> `pgadmin`
- Статус сервера: `/status` (`stub_status`)
- Управление: `/managment`

## Как запускать

```bash
docker compose -f deploy/docker-compose.lab4.yml up --build
```

После старта сервисов:

- `http://localhost:8088/`
- `http://localhost:8088/api/v1`
- `http://localhost:8088/managment`
