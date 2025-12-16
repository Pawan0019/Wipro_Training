# Computer Architecture – Day 1

Computer architecture defines the structure, behavior, and design of a computer system. It provides a conceptual understanding of how hardware components such as the CPU, memory, I/O devices, and storage interact to execute instructions. :contentReference[oaicite:0]{index=0}

---

## Layers of Computer Architecture

Computer architecture consists of three main layers:

### 1. Instruction Set Architecture (ISA)

The **ISA** defines:

- The set of instructions a processor can execute  
- Data types it can process  
- Registers and addressing modes  
- Machine language format  

**Examples:**  
- x86  
- ARM  
- RISC-V  

---

### 2. Microarchitecture

Microarchitecture defines how the ISA is implemented in hardware.

It includes:

- Pipelining  
- Branch prediction  
- Execution units  
- Cache hierarchy  
- Core design  

Different processors may implement the same ISA using different microarchitectures, resulting in variations in **performance** and **power efficiency**.

---

### 3. System Architecture

System architecture defines how the CPU communicates with peripherals, memory, and input/output devices.

It includes:

- Data buses (system bus, memory bus)  
- Storage controllers  
- Memory hierarchy  
- Interrupt systems  

---

Together, these layers ensure that high-level programs are translated into low-level operations that hardware can execute.

---

## Central Processing Unit (CPU)

The **CPU** is the *brain* of the computer. It performs arithmetic, logical, control, and input/output operations.

---

## Components of the CPU

### 1. Arithmetic Logic Unit (ALU)

Performs:

- Arithmetic operations (addition, subtraction, multiplication)  
- Logical operations (AND, OR, NOT)  
- Comparisons (equal to, greater than, less than)  

---

### 2. Control Unit (CU)

Responsible for:

- Fetching instructions  
- Decoding instructions  
- Executing or delegating tasks to the ALU and memory  

The CU ensures the correct flow of instructions during program execution.

---

### 3. Registers

Registers are the **fastest form of memory** and exist inside the CPU.

Types of registers include:

- **General-purpose registers** (e.g., RAX, RBX in x86)  
- **Special-purpose registers** (Program Counter, Stack Pointer)  
- **Status registers** (flags for zero, carry, overflow)  

---

### 4. Clock Speed

- Measured in **GHz**
- Higher clock speed → faster instruction cycles  

> Performance also depends on the number of cores, cache size, and microarchitecture.

---

## CPU Cores

### Core Concept

Earlier CPUs had a single core, meaning only one instruction stream could be executed at a time.  
Modern CPUs contain multiple cores (2, 4, 8, 16, or more), enabling parallel execution.

---

### Single-Core CPU

- Executes one thread at a time  
- Limited multitasking performance  

---

### Multi-Core CPU

- Each core behaves like a separate CPU  
- Better multitasking performance  
- Enables parallel processing for multi-threaded applications  

---

## Random Access Memory (RAM)

RAM is the primary memory used to store active programs and data during execution.

---

### Characteristics of RAM

- Volatile (data lost when power is off)  
- Fast read/write speeds  
- Measured in **GB** and **MHz**  

---

### Types of RAM

- **DRAM (Dynamic RAM):** Commonly used in computers  
- **SRAM (Static RAM):** Faster and more expensive; used in CPU cache  

---

### Functions of RAM

- Stores operating system data  
- Holds program variables and instructions  
- Provides workspace for applications  
- Supports multitasking by allocating memory blocks  

---

### RAM Performance Factors

- **Frequency** (e.g., 3200 MHz)  
- **Latency (CL):** Lower latency = faster access  
- **Bandwidth:** Amount of data transferred per second  

More RAM improves:

- Multitasking  
- Large dataset processing  
- Gaming performance  
- Machine learning workloads  

---

## Cache Memory

Cache memory is a small, ultra-fast memory located inside or close to the CPU. It reduces the time needed to access frequently used instructions and data.

---

### Cache Levels

Modern CPUs use a multi-level cache hierarchy:

#### L1 Cache
- Fastest and smallest (16–128 KB)  
- Split into instruction cache and data cache  
- Located inside each core  

#### L2 Cache
- Larger and slower than L1  
- Typically 256 KB – 1 MB  
- Per-core or shared  

#### L3 Cache
- Shared among all cores  
- Larger (4–64 MB)  
- Slower than L1/L2 but faster than RAM  

#### L4 Cache (Rare)
- Found in some high-end CPUs  
- Used as a shared last-level cache  

---

### Why Cache Memory is Needed

Accessing RAM is significantly slower than accessing cache.

Approximate access times:

- Registers: ~1 cycle  
- L1 Cache: ~4 cycles  
- L2 Cache: ~12 cycles  
- L3 Cache: ~40 cycles  
- RAM: ~100–200 cycles  

Cache improves CPU efficiency by:

- Storing frequently accessed data  
- Reducing memory latency  
- Keeping the instruction pipeline filled  

---
