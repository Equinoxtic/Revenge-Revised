#include <iostream>
#include <string>

#ifndef PARSER_H
#define PARSER_H

using namespace std;

string parse_str(string parsestr) {
	return (!parsestr.empty()) ? parsestr : "NULL";
}

int parse_int(int parseint) {
	return (parseint != 0) ? parseint : 0;
}

#endif
