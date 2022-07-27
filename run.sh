#!/bin/bash
dotnet build
cp cursor.txt bin/Debug/net6.0/
cp version.txt bin/Debug/net6.0/
clear
start bin/Debug/net6.0/Revenge.exe