#!/bin/bash

set -e

[ -z "$PROJECT_ROOT" ] && echo "Need to set PROJECT_ROOT" && exit 1;
[ -z "$SONAR_URL" ] && echo "Need to set SONAR_URL" && exit 1;
[ -z "$SONAR_TOKEN" ] && echo "Need to set SONAR_TOKEN" && exit 1;
[ -z "$PROJECT_KEY" ] && echo "Need to set PROJECT_KEY" && exit 1;
[ -z "$PROJECT_VERSION" ] && echo "Need to set PROJECT_VERSION" && exit 1;

if [[ "$OSTYPE" == "darwin"* ]]; then
    realpath() {
        [[ $1 = /* ]] && echo "$1" || echo "$PWD/${1#./}"
    }
fi

SCRIPT_PATH=$(dirname $(realpath "$0"))

docker run -it --rm \
    -v $(echo $PROJECT_ROOT)/:/app \
    -v "$SCRIPT_PATH/sonar-entrypoint.sh":/sonar-entrypoint.sh \
    --env="SONAR_BIN_DIR=" \
    --env="SONAR_URL=${SONAR_URL}" \
    --env="SONAR_TOKEN=${SONAR_TOKEN}" \
    --env="PROJECT_KEY=${PROJECT_KEY}" \
    --env="PROJECT_VERSION=${PROJECT_VERSION}" \
    --workdir=/app \
    --entrypoint=/sonar-entrypoint.sh \
    --add-host=tco-intcon-srv:10.132.200.130 \
    nosinovacao/dotnet-sonar
