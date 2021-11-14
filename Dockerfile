FROM postgres:9.6
MAINTAINER "Lester Cerioli: Lucas Technology Services" <eea-edw-a-team-alerts@googlegroups.com>

ENV PG_ARCHIVE=/var/lib/postgresql/archive \
    PG_CONFD=/postgresql.conf.d \
    PG_RESTORE=/postgresql.restore \
    PG_BACKUP=/postgresql.backup

RUN apt-get update -q \
 && apt-get install -y --no-install-recommends python3 iputils-ping\
 && apt-get clean \
 && rm -rf /var/lib/apt/lists/* \
 && mkdir -p $PG_ARCHIVE $PG_CONFD $PG_RESTORE $PG_BACKUP \
 && chown -R postgres:postgres $PG_ARCHIVE $PG_CONFD $PG_RESTORE $PG_BACKUP \
 && mv /docker-entrypoint.sh /master-entrypoint.sh

COPY database-backup.sh database-restore.sh /postgresql.restore/
COPY replica-entrypoint.sh docker-entrypoint.sh /
COPY crond.sh setup-env.py /bin/
COPY setup-*.sh /docker-entrypoint-initdb.d/
COPY default.conf /postgresql.conf.d/

ENTRYPOINT ["/docker-entrypoint.sh"]
CMD ["postgres"]