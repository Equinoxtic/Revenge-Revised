#include <iostream>
#include <string>
#include <windows.h>
#include "../options/optionshandler.h"
#include "../display/cursor.h"
#include "../display/textdivider.h"
#include "../display/title.h"
#include "../revlib/parser.h"

#ifndef RUN_H
#define RUN_H

using namespace std;

void run(bool showOptions) 
{
	string userInput = "";
	int userInputInt;
	
	SetConsoleTitleA("Revenge");

	prntTitle();

	if (showOptions) {
		getOptions();
	} else {
		createDivider("-", 24, true, true);
	}

	cout << getCursor();
	cin >> userInput;
	
	if (userInput.rfind("--", 0) == 0) {
		checkCommandOption(parse_str(userInput));
	} else {
		userInputInt = stoi(userInput);
		checkOptionInput(parse_int(userInputInt));
	}
}

#endif
