mermaid 
    
classDiagram
Character <|-- Player
Character <|-- Enemy
Character <|-- Weapon
Weapon <|-- Gun
Weapon <|-- Sword
Weapon -- Player 
Weapon -- Enemy
Character : Weapons[] Weapon[]
Character : Name String
Character : Fight()
Weapon: Power float
Gun: Ammo int
Gun: FireGun()
Sword: BladeLength float
Sword: AttackWithSword()
