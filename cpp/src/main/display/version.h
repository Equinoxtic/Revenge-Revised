#include <iostream>
#include <string>
#include <fstream>
#include "..\revlib\mrtrn.h"

#ifndef VERSION_H
#define VERSION_H

using namespace std;

string getVersion() {
	string version_str;
        ifstream version("version");
	if (!version.fail()) {
	    version >> version_str;
	}
	return (!version.fail()) ? version_str : "No version.";
	mrtrn(false);
}

#endif
