#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class Strings
{
protected:
    vector<char> value;

public:
    Strings(vector<char> value)
    {
        this->value = value;
    }

    int Length()
    {
        return value.size();
    }

    string ToString()
    {
        return string(value.begin(), value.end());
    }
};

class NumericStrings : public Strings
{
public:
    NumericStrings(vector<char> value) : Strings(value)
    {
        // Перевірка на введення числа
        for (char c : value)
        {
            if (!isdigit(c))
            {
                throw invalid_argument("Value must be a numeric string");
            }
        }
    }

    vector<char> Reverse()
    {
        reverse(value.begin(), value.end());
        return value;
    }
};

int main()
{
    vector<Strings*> stringsList;

    while (true)
    {
        cout << "Select class: 1. Strings, 2. NumericStrings, 3. Exit" << endl;
        int classChoice;
        cin >> classChoice;

        if (classChoice == 3)
        {
            break;
        }

        cout << "Enter value: ";
        string value;
        cin >> value;
        vector<char> chars(value.begin(), value.end());

        Strings* stringsObj;
        if (classChoice == 2)
        {
            try
            {
                stringsObj = new NumericStrings(chars);
            }
            catch (const invalid_argument& e)
            {
                cout << e.what() << endl;
                continue;
            }
        }
        else
        {
            stringsObj = new Strings(chars);
        }

        stringsList.push_back(stringsObj);
        cout << "Object added" << endl;

        while (true)
        {
            cout << "Select function: 1. Get value, 2. Get length, 3. Reverse, 4. Create new object, 5. Exit" << endl;
            int functionChoice;
            cin >> functionChoice;

            switch (functionChoice)
            {
                case 1:
                    cout << "Value: " << stringsObj->ToString() << endl;
                    break;
                case 2:
                    cout << "Length: " << stringsObj->Length() << endl;
                    break;
                case 3:
                    if (classChoice != 2)
                    {
                        cout << "Error: Reverse function only available for NumericStrings" << endl;
                        break;
                    }
                static_cast<NumericStrings*>(stringsObj)->Reverse();
                    cout << "Reversed Value: " <<stringsObj->ToString() << endl;
                    break;
                case 4:
                    break;
                case 5:
                    return 0;
                default:
                    cout << "Invalid choice" << endl;
                    break;
            }

            if (functionChoice == 4)
            {
                break;
            }
        }
    }

    return 0;
}
