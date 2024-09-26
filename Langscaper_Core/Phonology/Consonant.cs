namespace CSP_Core.Phonology;

public enum GeneralPlaceOfArticulation
{
    Labial,
    Coronal,
    Dorsal,
    Laryngeal,
    Undefined
}

public enum SpecificPlaceOfArticulation
{
    Bilabial,
    LabioDental,
    LinguoLabial,
    Dental,
    Alveolar,
    PostAlveolar,
    Retroflex,
    Palatal,
    Velar,
    Uvular,
    PharyngealOrEpiglotal,
    Glottal
}

public enum MannerOfArticulation
{
    Nasal,
    Plosive,
    SibilantAffricate,
    NonSibilantAffricate,
    SibilantFricative,
    NonSibilantFricative,
    Approximant,
    TapOrFlap,
    Trill,
    LateralAffricate,
    LateralFricative,
    LateralApproximant,
    LateralTapOrFlap

}

public enum Voicing
{
    Voiced,
    Voiceless,
    Undefined
}

public enum Mechanism
{
    Pulmonic,
    Ejective,
    Click,
    Imposive
}

public enum Sonorance
{
    Sonorant,
    Obstruent,
    Undefined
}

public readonly record struct Consonant(string Symbol, GeneralPlaceOfArticulation GeneralPlaceOfArticulation, SpecificPlaceOfArticulation SpecificPlaceOfArticulation, Voicing Voicing, Mechanism Mechanism, Sonorance Sonorance)
{
    // From https://en.wikipedia.org/wiki/List_of_consonants
    public static Consonant VoicelessBilabialNasalStop = new("m̥", GeneralPlaceOfArticulation.Labial, SpecificPlaceOfArticulation.Bilabial, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);
    public static Consonant VoicedBilabialNasal = new("m", GeneralPlaceOfArticulation.Labial, SpecificPlaceOfArticulation.Bilabial, Voicing.Voiced, Mechanism.Pulmonic, Sonorance.Sonorant);
    public static Consonant VoicelessLabioDentalNasalStop = new("ɱ̊", GeneralPlaceOfArticulation.Labial, SpecificPlaceOfArticulation.LabioDental, Voicing.Voiceless, Mechanism.Pulmonic, Sonorance.Obstruent);

    public static List<Consonant> AllConsonants =
    [
        VoicelessBilabialNasalStop
    ];
}