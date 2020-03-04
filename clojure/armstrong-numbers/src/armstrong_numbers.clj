(ns armstrong-numbers
  (:require [clojure.string :as str]
            [clojure.math.numeric-tower :as math]))

(defn num-to-digits [num]
      (->> num
           str
           (map #(Character/digit % 10))))

(defn armstrong? [num]
      (let [digits (num-to-digits num)
            exponent (count digits)]
        (->> digits
             (map #(math/expt % exponent))
             (reduce +)
             (= num))))
