namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_get_name_and_age_when_is_a_person_if_given_name_and_age()
        {
            var person = new Person(name: "Tom", age: 21);
            var res = person.Print();
            Assert.Equal("My name is Tom.I am 21 years old.", res);
        }

        [Fact]
        public void Should_get_name_age_and_title_when_is_a_student_if_given_name_age_and_title_as_student()
        {
            var student = new Student(name: "Tom", age: 21);
            var res = student.Print();
            Assert.Equal("My name is Tom.I am 21 years old.I am a student.", res);
        }

        [Fact]
        public void Should_get_name_age_and_title_when_is_a_teacher_if_given_name_age_and_title_as_teacher()
        {
            var teacher = new Teacher(name: "Amy", age: 30);
            var res = teacher.Print();
            Assert.Equal("My name is Amy.I am 30 years old.I am a teacher.", res);
        }

        [Fact]
        public void Should_get_name_age_title_and_class_when_is_a_student_if_given_name_age_title_and_class_as_student()
        {
            var student = new Student(name: "Tom", age: 18);
            var ooclass = new OOClass(name: 2);
            ooclass.AddStudent(student);
            var res = student.Print();
            Assert.Equal("My name is Tom.I am 18 years old.I am a student of class 2.", res);
        }

        [Fact]
        public void Should_get_name_age_title_and_class_when_is_a_teacher_if_given_name_age_title_and_class_as_teacher()
        {
            var teacher = new Teacher(name: "Amy", age: 30);
            var ooclass = new OOClass(name: 2);
            ooclass.AddOrChangeTeacher(teacher);
            var res = teacher.Print();
            Assert.Equal("My name is Amy.I am 30 years old.I am a teacher of class 2.", res);
        }
    }
}
