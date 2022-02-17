pipeline { 
        agent {label 'windows'}  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps{
                bat 'msbuild -t:restore ApiExampleFramework\\ExampleFramework.csproj'
                bat 'msbuild -t:restore ApiExampleFramework.Tests\\ExampleFramework.Tests.csproj'
                bat 'msbuild .' 
            }
        }            
    }
}