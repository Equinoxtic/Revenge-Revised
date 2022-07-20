#include <iostream>

#ifndef ERRORPARSE_H
#define ERRORPARSE_H

using namespace std;

void throwInvalidError(string reason) {
	cout << "\nInvalid " << reason << ", please try again.\n";
}

#endif
