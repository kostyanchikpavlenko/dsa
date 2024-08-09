// See https://aka.ms/new-console-template for more information

using DataStructures.LinkedLists;

var list = new SinglyLinkedList<int>();

var node1 = Node<int>.Create(1);
var node2 = Node<int>.Create(2);
var node3 = Node<int>.Create(3);

list.AddLast(node1);
list.AddLast(node2);
list.AddLast(node3);


list.Remove(node1);





//
// var result = list.Find(5);
// var result2 = list.Find(6);
//
// var first = list.GetFirst();
// var last = list.GetLast();

foreach (var item in list)
{
    Console.WriteLine(item.Value);
}