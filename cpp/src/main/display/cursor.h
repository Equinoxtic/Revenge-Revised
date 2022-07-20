#include <iostream>
#include <string>
#include <fstream>

#ifndef CURSOR_H
#define CURSOR_H

using namespace std;

string setCursor(string cursor_ch) {
	return (!cursor_ch.empty()) ? cursor_ch + " " : "> ";
}

string getCursor() {
	string cursor_str;
	ifstream cursor("cursor");
	if (!cursor.fail()) {	
		cursor >> cursor_str;
	}
	return (!cursor.fail()) ? cursor_str + " " : "> ";
}

#endif
