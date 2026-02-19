#!/usr/bin/env bash
set -e

if [ ! -s "$PGDATA/PG_VERSION" ]; then
  rm -rf "$PGDATA"/*
  until pg_isready -h postgres-master -U postgres >/dev/null 2>&1; do
    sleep 1
  done
  PGPASSWORD="$REPLICATION_PASSWORD" pg_basebackup -h postgres-master -D "$PGDATA" -U "$REPLICATION_USER" -Fp -Xs -P -R
fi

exec postgres
