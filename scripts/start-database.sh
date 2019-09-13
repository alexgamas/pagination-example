
if [[ "$OSTYPE" == "darwin"* ]]; then
    realpath() {
        [[ $1 = /* ]] && echo "$1" || echo "$PWD/${1#./}"
    }
fi

SCRIPT_PATH=$(dirname $(realpath "$0"))

docker-compose -f $SCRIPT_PATH/stack.yaml up -d
