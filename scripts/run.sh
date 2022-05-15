#!/bin/bash

SCRIPT_DIR="$( cd "$( dirname "$0" )" && pwd )"

dotnet clean $SCRIPT_DIR/../fsharp_test.sln
if [ $? -gt 0 ] 
then 
    echo "Cleaning error"
    exit
fi
dotnet build $SCRIPT_DIR/../fsharp_test.sln
if [ $? -gt 0 ] 
then 
    echo "Building error"
    exit
fi
dotnet test $SCRIPT_DIR/../fsharp_test.sln
if [ $? -gt 0 ] 
then 
    echo "Tests error"
    exit
fi
dotnet pack -c Release $SCRIPT_DIR/../fsharp_test.sln
if [ $? -gt 0 ] 
then 
    echo "Packing error"
    exit
fi