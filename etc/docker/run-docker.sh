#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 8da6f3b7-cf53-4885-a0b5-bff48ce1038e -t
    fi
    cd ../
fi

docker-compose up -d
