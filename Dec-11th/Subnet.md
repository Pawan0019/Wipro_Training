# Subnet

A subnet (short for subnetwork) is a smaller, logical section of a larger network. :contentReference[oaicite:0]{index=0}

Subnetting divides a network into multiple smaller networks to improve management, security, and performance.

Subnetting is the process of dividing a large network into smaller networks called subnets. Each subnet provides its own space for devices to communicate, improving network performance, security, and management.

Think of a subnet like dividing a big city into smaller neighborhoods. Each neighborhood is easier to manage.

---

## Why Do We Use Subnets?

### 1. Reduce Network Congestion (Less Traffic)

Smaller networks produce less broadcast traffic, making communication faster.

### 2. Improve Security

You can isolate groups of devices.

For example:

HR computers in one subnet  
Finance in another  

### 3. Better Network Management

Subnets allow administrators to organize devices logically.

### 4. Efficient IP Address Usage

Subnetting helps avoid wastage of IP addresses.

---

## Key Concepts in Subnetting

### IP Addressing

An IP address is made up of different parts, each serving a specific purpose in identifying a device on a network. An IPv4 address consists of four parts called "octets," separated by dots (e.g., 192.168.1.1). It has two main sections:

Network Portion: Identifies the network the device belongs to.

Host Portion: Uniquely identifies a device within the network.

IPv4 addresses are divided into classes based on the length of the network and host portions:

Class A: 8-bit network ID, 24-bit host ID.

Class B: 16-bit network ID, 16-bit host ID.

Class C: 24-bit network ID, 8-bit host ID.

---

## What is a Subnet Mask?

A subnet mask is a 32-bit number used in IP addressing to separate the network portion of an IP address from the host portion.

It helps computers and devices determine which part of an IP address refers to the network they are present in, and which part refers to their specific location or address within that network.

Example:

IP Address: 192.168.1.10  
Subnet Mask: 255.255.255.0  

This means:

Network part: 192.168.1  

Host part: 10  

---

## Types of Subnets

### 1. Classful Subnets (Old Method)

Used fixed sizes (Class A, B, C).  
Not used much today.

### 2. Classless Subnets (CIDR — Modern Method)

Allows flexible subnet sizes using prefix notation:

Examples:

/24  
/26  
/30  

CIDR is widely used today due to its flexibility.

---

## How Subnetting Works?

The working of subnets starts in such a way that firstly it divides the subnets into smaller subnets. For communicating between subnets, routers are used. Each subnet allows its linked devices to communicate with each other. Subnetting for a network should be done in such a way that it does not affect the network bits.

In class C the first 3 octets are network bits so it remains as it is.

For Subnet-1: The first bit which is chosen from the host id part is zero and the range will be from (193.1.2.00000000 till you get all 1's in the host ID part i.e, 193.1.2.01111111) except for the first bit which is chosen zero for subnet id part.

Thus, the range of subnet 1 is: 193.1.2.0 to 193.1.2.127

Subnet id of Subnet 1 is: 193.1.2.0  
The direct Broadcast id of Subnet-1 is: 193.1.2.127  
The total number of hosts possible is: 126 (Out of 128, 2 id's are used for Subnet id & Direct Broadcast id)  
The subnet mask of Subnet- 1 is: 255.255.255.128  

For Subnet-2: The first bit chosen from the host id part is one and the range will be from (193.1.2.100000000 till you get all 1's in the host ID part i.e, 193.1.2.11111111).

Thus, the range of subnet-2 is: 193.1.2.128 to 193.1.2.255

Subnet id of Subnet 2 is : 193.1.2.128  
The direct Broadcast id of Subnet-2 is: 193.1.2.255  
The total number of hosts possible is: 126 (Out of 128, 2 id's are used for Subnet id & Direct Broadcast id)  
The subnet mask of Subnet- 2 is: 255.255.255.128  

The best way to find out the subnet mask of a subnet is to set the fixed bit of host-id to 1 and the rest to 0.

Finally, after using the subnetting the total number of usable hosts is reduced from 254 to 252.

---

## Note

To divide a network into four (2 2 ) parts you need to choose two bits from the host id part for each subnet i.e, (00, 01, 10, 11).

To divide a network into eight (2 3 ) parts you need to choose three bits from the host id part for each subnet i.e, (000, 001, 010, 011, 100, 101, 110, 111) and so on.

We can say that if the total number of subnets in a network increases the total number of usable hosts decreases.

The network can be divided into two parts: To divide a network into two parts, you need to choose one bit for each Subnet from the host ID part.
