import random

class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
    def __init__(self):
        self.head = None

    def append(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
            return
        last = self.head
        while last.next:
            last = last.next
        last.next = new_node

    def display(self):
        current = self.head
        while current:
            print(current.data, end=" -> ")
            current = current.next
        print("None")

def guess_number():
    number_to_guess = random.randint(1, 100)
    attempts = LinkedList()
    guess = None

    print("Adivinhe o número entre 1 e 100!")

    while guess != number_to_guess:
        guess = int(input("Digite seu palpite: "))
        attempts.append(guess)

        if guess < number_to_guess:
            print("Muito baixo! Tente novamente.")
        elif guess > number_to_guess:
            print("Muito alto! Tente novamente.")
        else:
            print("Parabéns! Você adivinhou o número!")

    print("Tentativas feitas:")
    attempts.display()

if __name__ == "__main__":
    guess_number()