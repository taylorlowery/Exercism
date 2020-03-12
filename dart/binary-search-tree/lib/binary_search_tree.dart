class BinarySearchTree {
  // Put your code here
  Node root;
  BinarySearchTree(String val) {
    this.root = new Node(val);
  }

  void insert(String val) {
    root.insert(new Node(val));
  }
}

class Node {
  String data;
  int value;
  Node left;
  Node right;
  Node(String data) {
    this.data = data;
    this.value = int.parse(data);
  }

  void insert(Node newNode) {
    if (newNode.value == this.value) {
      if (this.left == null) {
        this.left = newNode;
      } else if (this.right == null) {
        this.right = newNode;
      } else {
        this.left.insert(newNode);
      }
    }
    if (newNode.value < this.value) {
      if (this.left == null) {
        this.left = newNode;
      } else {
        this.left.insert(newNode);
      }
    } else if (newNode.value > this.value) {
      if (this.right == null) {
        this.right = newNode;
      } else {
        this.right.insert(newNode);
      }
    }
  }
}
