#include <iostream>
#include "option.h"
#include "..\events\runoption.h"
#include "..\events\runcommand.h"
#include "..\display\textdivider.h"

#ifndef OPTIONSHANDLER_H
#define OPTIONSHANDLER_H

using namespace std;

void getOptions()
{
	createDivider("-", 120, true, true);

	cout << "\n";

	addCategory("Category", true, true, 6);
	addOption(1, "Test Option 1", true, true, 6);
	addOption(2, "test Option 2", true, true, 6);
	addOption(3, "test Option 3", true, true, 6); 

	cout << "\n";

	createDivider("-", 120, true, true);

	cout << "\n";
}

void checkOptionInput(int input)
{
	runOption(input);
}

void checkCommandOption(string cmd)
{
	runCommand(cmd);
}

#endif
