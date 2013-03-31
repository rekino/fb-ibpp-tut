#ifndef TABLE_H
#define TABLE_H

#include <map>
namespace AutorunLibrary
{
template<class T>
class Table
{
private:
    std::map<int, T> _rows;
public:
    Table(){}
    void Add(int id, T row)
    {
        _rows[id] = row;
    }
};
}

#endif // TABLE_H
