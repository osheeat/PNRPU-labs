#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

bool wordlikefirst(vector<string>Listofwords)
{
	for (int i = 1; i < Listofwords.size(); i++)
	{
		if (Listofwords[0] == Listofwords[i])
			return true;	
	}
	return false;
}
string DeleteSpaces(string line)
{
	while (line.find("  ") != -1)
		line.replace(line.find("  "), 2, " ");
	if (line[0] == ' ') 
		line.erase(0, 1);
	if (line[line.length() - 1] == ' ') 
		line.erase(line.length() - 1);
	return line;
}

 vector<string> StringToWords(string line)
{
	 vector<string> res;
	 line = DeleteSpaces(line);
	 int wordBeginning = 0;
	 for (int i = 0; i < line.length(); i++)
	 {
		 if (line[i] == ' ')
		 {
			 string lineCopy = line;
			 res.push_back(lineCopy.erase(i).erase(0, wordBeginning));
			 wordBeginning = i + 1;
			 i++;
		 }
	 }
	 res.push_back(line.erase(0, wordBeginning));
	 return res;
 }


 int main()
{
	ifstream in("F1.txt");
	string NewWords;
	if (in.is_open())
	{
		ofstream out("F2.txt");
		while (!in.eof())
		{
			string currentline;
			getline(in, currentline);
			vector<string>Words = StringToWords(currentline);
			if (wordlikefirst(Words)) 
			{ 
				out << currentline << endl;
				NewWords = currentline;
			}
		}
		cout << NewWords << endl;
		int soglasn = 0;
		string need = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
		for (int i = 0;i<need.length();i++)
			for (int j = 0; j < NewWords.size(); j++)
			{
				if (need[i]==NewWords[j])
					soglasn++;
			}
		cout << soglasn << endl;	
		out.close();
	}
	else
		cout << "Error!" << endl;
	in.close();	
}

