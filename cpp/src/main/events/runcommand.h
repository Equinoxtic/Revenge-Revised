#include <iostream>
#include "..\revlib\errorparse.h"
#include "..\display\version.h"

#ifndef RUNCOMMAND_H
#define RUNCOMMAND_H

using namespace std;

void runCommand(string command)
{
	if (!command.empty()) {
		if (command == "--exit") {
			exit(1);
		} else if (command == "--version") {
			cout << getVersion();
		}
	} else {
		throwInvalidError("Command");
	}
}

#endif
