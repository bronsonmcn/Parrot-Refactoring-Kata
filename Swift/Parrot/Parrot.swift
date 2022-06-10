import Foundation

class Parrot {
    private let parrotType: ParrotType
    private let numberOfCoconuts: Int
    private let voltage: Double
    private let isNailed: Bool

    init(_ parrotType: ParrotType, numberOfCoconuts: Int, voltage: Double, isNailed: Bool) {
        self.parrotType = parrotType
        self.numberOfCoconuts = numberOfCoconuts
        self.voltage = voltage
        self.isNailed = isNailed
    }

    var speed: Double {
        switch parrotType {
        case .european:
            return baseSpeed

        case .african:
            return max(0, baseSpeed - loadFactor * Double(numberOfCoconuts))

        case .norwegianBlue:
            return (isNailed) ? 0 : baseSpeed(voltage: voltage)
        }
    }

    private func baseSpeed(voltage: Double) -> Double {
        min(24.0, voltage * baseSpeed)
    }

    private var loadFactor: Double {
        9.0
    }

    private var baseSpeed: Double {
        12.0
    }
}
