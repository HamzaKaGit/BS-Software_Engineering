#!/usr/bin/env python
# coding: utf-8

# In[21]:


class math():
    def __init__(self,a,b):
        self.a1=a
        self.b1=b
        print("constructor called")
    def add(self):
        return self.a1+self.b1
    def sub(self):
        return self.a1-self.b1
    def mul(self):
        return self.a1*self.b1
    def div(self):
        return self.a1/self.b1
a=math(5,4)
print ("result", a.add())


# In[25]:


class math1(math):
    pass

a=math1(8,4)
print("child constructor called")
print ("result", a.sub())


# In[1]:


def find_largest(num_list):
    largest_num = num_list[0]
    for num in num_list:
        if num>largest_num:
            largest_num=num
        return largest_num
 
numbers=[]
for i in range(10):
    num = int(input("Enter Number: "))
    numbers.append(num)
    
largest_number = find_largest(numbers)
print("The largest number is: ",largest_number)


# In[4]:


class basic_calc():
    def __init__(self,a,b):
        self.a1=a
        self.b1=b
        print("Values Initialized")
    def add(self):
        return self.a1+self.b1
    def sub(self):
        return self.a1-self.b1
    def mul(self):
        return self.a1*self.b1
    def div(self):
        return self.a1/self.b1
a=basic_calc(5,4)
print ("Addition Result: ", a.add())
print ("Subtraction Result: ", a.sub())
print ("Multiplication Result: ", a.mul())
print ("Divison Result: ", a.div())
    


# In[ ]:




